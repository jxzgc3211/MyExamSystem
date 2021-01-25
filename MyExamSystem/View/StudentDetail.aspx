<%@ Page Title="" Language="C#" MasterPageFile="~/View/TeacherMain.Master" AutoEventWireup="true" CodeBehind="StudentDetail.aspx.cs" Inherits="MyExamSystem.View.StudentDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table class="table table-bordered table-hover">
            <tr>
                <td>编号：</td>
                <td> <asp:Label ID="stuId" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td>姓名：</td>
                <td> <asp:Label ID="stuName" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td>登录名：</td>
                <td> <asp:Label ID="stuLoginName" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td>性别：</td>
                <td> <asp:Label ID="stuSex" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td>电话：</td>
                <td> <asp:Label ID="stuPhone" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td>邮箱：</td>
                <td> <asp:Label ID="stuEmai" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td>系别：</td>
                <td> <asp:Label ID="stuGrade" runat="server" Text="Label"></asp:Label></td>
            </tr>
        </table>
        <a href="StudentPage.aspx" class="btn btn-success">返回学生管理界面</a>
    </div>
</asp:Content>
