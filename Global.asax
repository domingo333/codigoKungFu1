﻿<%@ Application Language="C#" %>

<script runat="server"> 

    void Application_Start(object sender, EventArgs e) 
    {
       
        // Código que se ejecuta al iniciarse la aplicación
        ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "~/Scripts/jquery-3.1.1.min.js",
                DebugPath = "~/Scripts/jquery-3.1.1.js",
                CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jquery/jquery-1.9.0.js",
                CdnPath = "http://ajax.aspnetcdn.com/ajax/jquery/jquery-1.8.3.min.js"
            });

    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Código que se ejecuta al cerrarse la aplicación

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Código que se ejecuta cuando se produce un error sin procesar

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Código que se ejecuta al iniciarse una nueva sesión

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Código que se ejecuta cuando finaliza una sesión. 
        // Nota: el evento Session_End se produce solamente con el modo sessionstate
        // se establece como InProc en el archivo Web.config. Si el modo de sesión se establece como StateServer
        // o SQLServer, el evento no se produce.

    }
       
</script>
