
⭐ Don't forget to star this app as it's using latest tools and technology ⭐

This is an open-source repo. If you would like to add something or correct a mistake, please open a PR.

# Pro.APIConsume 🚀
A web API  that fetches and display data from [Helsinki Region Transport HSL Open Data](https://www.hsl.fi/en/hsl/open-data) - Park &amp; Ride Information System REST APIs. 

## Table of contents
Welcome to my new single-page application, built with:

* [ASP.NET Core](https://dotnet.microsoft.com/en-us/apps/aspnet) v6.0 🚀and [C#](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/?redirectedfrom=MSDN) v10.0 for cross-platform server-side code
* [React](https://react.dev/) v18.2.0 for client-side code
* [Bootstrap](https://getbootstrap.com/) v5.1.3 for layout and styling
* [JSON.NET](https://www.newtonsoft.com/json) v13.0 for deserialize API responses with Json.NET's powerful JSON serializer
* [System.Net.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=net-7.0) for sending HTTP requests and receiving HTTP responses from a resource identified by a URI

* [MVCApiController](https://learn.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-7.0) to enable the following opinionated, API-specific behaviors:
    1. Attribute routing requirement
    2. Automatic HTTP 400 responses
    3. Binding source parameter inference
    4. Multipart/form-data request inference
    5. Problem details for error status codes

Here, I have also enabled:

* **Client-side navigation** For example, click Counter then Back to return here.
* **Development server integration** In development mode, the development server from create-react-app runs in the background automatically, so client-side resources are dynamically built on demand and the page refreshes when any file is modified.
* **Efficient production builds** In production mode, development-time features are disabled, and dotnet publish configuration produces minified, efficiently bundled JavaScript files.


The ClientApp subdirectory is a standard React application based on the create-react-app template. Open a command prompt in that directory, run [npm](https://www.npmjs.com/) commands such as npm test or npm install.
