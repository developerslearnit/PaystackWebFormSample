<%@ Page Async="true" Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PaystckWebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   

    <div class="row" style="padding-top:50px">
        <asp:Button ID="payNow" CssClass="btn btn-primary btn-block" runat="server" Text="Pay Now" OnClick="payNow_Click" />
    </div>

</asp:Content>
