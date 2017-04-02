<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" Async="true" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GoogleAPIConsumption._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


        <div class="form-horizontal">
        <h4>Shorten URL</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <p class="text-danger">
            <asp:Literal runat="server" ID="ErrorMessage" />
        </p>
              <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="APIKey" CssClass="col-md-2 control-label">API Key</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="APIKey" CssClass="form-control" TextMode="SingleLine" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="APIKey"
                    CssClass="text-danger" ErrorMessage="The API KEY  is required." />
                <p>Get your Key from:</p>
                <a href="https://developers.google.com/url-shortener/v1/getting_started"  >APIKey</a>
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="LongURL" CssClass="col-md-2 control-label">LongURL</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="LongURL" CssClass="form-control" TextMode="Url" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="LongURL"
                    CssClass="text-danger" ErrorMessage="The Long URL field is required." />
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="SubmitURL_Click"
                    Text="Submit" CssClass="btn btn-default" />
            </div>
        </div>
    </div>

     <asp:HyperLink runat="server" ID="ShortLink"  ></asp:HyperLink>
 

</asp:Content>
