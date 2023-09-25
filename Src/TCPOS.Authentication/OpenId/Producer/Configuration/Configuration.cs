﻿namespace TCPOS.Authentication.OpenId.Producer.Configuration;

public sealed class Configuration
{
    internal Configuration()
    { }

    public bool AllowClientCredentialsFlow
    {
        get;
        set;
    } = false;

    public bool AllowAuthorizationCodeFlow
    {
        get;
        set;
    } = false;

    public bool RequirePKCE
    {
        get;
        set;
    } = false;

    public string AuthorizationEndpointUri
    {
        get;
        set;
    } = "";

    public string TokenEndpointUri
    {
        get;
        set;
    } = "";

    public Application Application
    {
        get;
    } = new();
}
