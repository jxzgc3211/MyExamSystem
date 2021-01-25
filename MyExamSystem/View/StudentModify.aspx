<%@ Page Title="" Language="C#" MasterPageFile="~/View/TeacherMain.Master" AutoEventWireup="true" CodeBehind="StudentModify.aspx.cs" Inherits="MyExamSystem.View.StudentModify" %>
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
                <td> <asp:TextBox ID="stuName" runat="server" Text="Label"></asp:TextBox></td>
            </tr>
            <tr>
                <td>登录名：</td>
                <td> <asp:TextBox ID="stuLoginName" runat="server" Text="Label"></asp:TextBox></td>
            </tr> <tr>
                <td>密码：</td>
                <td> <asp:TextBox ID="stuPwd" runat="server" Text="Label"></asp:TextBox></td>
            </tr>
            <tr>
                <td>性别：</td>
                <td> <asp:TextBox ID="stuSex" runat="server" Text="Label"></asp:TextBox></td>
            </tr>
            <tr>
                <td>电话：</td>
                <td> <asp:TextBox ID="stuPhone" runat="server" Text="Label"></asp:TextBox></td>
            </tr>
            <tr>
                <td>邮箱：</td>
                <td> <asp:TextBox ID="stuEmai" runat="server" Text="Label"></asp:TextBox></td>
            </tr>
            <tr>
                <td>系别：</td>
                <td> <asp:TextBox ID="stuGrade" runat="server" Text="Label"></asp:TextBox></td>
            </tr>
        </table>
        <asp:Button ID="stuUpdate" runat="server" Text="提交更新" OnClick="stuUpdate_Click" />
        <a href="StudentPage.aspx" class="btn btn-success">返回学生管理界面</a>
    </div>
</asp:Content>
