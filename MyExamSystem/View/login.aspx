<%@ Page Title="" Language="C#" MasterPageFile="~/View/Header.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="MyExamSystem.View.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <h1><asp:Label ID="Msg" runat="server" Text="教师登录"></asp:Label></h1>
        <%--隐藏域，用来传值，在页面上不会显示任何内容--%>
        <asp:HiddenField ID="HiddenField1" runat="server" />
        <table class="table">
            <tr>
                <td>用户名：</td>
                <td>
                    <asp:TextBox ID="UserName" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td>密码：</td>
                <td>
                    <asp:TextBox ID="PassWord" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2"> 
                    <asp:Button ID="btn_login" runat="server" Text="登录" OnClick="btn_login_Click" />
                </td>
               
            </tr>
        </table>
    </div>
</asp:Content>
