using System.Text;

namespace HRDroneAPI.Middleware
{
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            //await _next.Invoke(context);

            string accessPath = context.Request.Path.Value!.ToLower();
            if (IsNotAuthenPath(accessPath))
                await _next.Invoke(context);
            else
            {
                string authHeader = context.Request.Headers["Authorization"];
                if (authHeader != null && authHeader.StartsWith("Basic"))
                {
                    //Extract credentials
                    string encodedUsernamePassword = authHeader.Substring("Basic ".Length).Trim();
                    Encoding encoding = Encoding.GetEncoding("iso-8859-1");
                    string usernamePassword = encoding.GetString(Convert.FromBase64String(encodedUsernamePassword));

                    int seperatorIndex = usernamePassword.IndexOf(':');

                    var username = usernamePassword.Substring(0, seperatorIndex);
                    var password = usernamePassword.Substring(seperatorIndex + 1);

                    if (username == "HRDroneAPI" && password == "HRD#2022")
                    {
                        await _next.Invoke(context);
                    }
                    else
                    {
                        context.Response.StatusCode = 401; //Unauthorized
                        return;
                    }
                }
                else
                {
                    // no authorization header
                    context.Response.StatusCode = 401; //Unauthorized
                    return;
                }
            }
        }

        private bool IsNotAuthenPath(string path)
        {
            bool flag = false;
            if (path.IndexOf("swagger") > -1)
                flag = true;
            else if (path.IndexOf("session") > -1)
                flag = true;
            else
            {
                switch (path)
                {
                    case "/":
                    case "/index.html":
                    case "/envision/hremp/getdatawithusername":
                    case "/envision/hremp/getversion":
                        flag = true;
                        break;
                }
            }
            return flag;
        }
    }
}
