<%@ Page Title="" Language="C#" MasterPageFile="~/View/TeacherMain.Master" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="MyExamSystem.View.AddStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table class="table table-bordered table-hover">
            <tr>
                <td>姓名：</td>
                <td>
                    <asp:TextBox ID="stuName" runat="server" Text=""></asp:TextBox></td>
            </tr>
            <tr>
                <td>登录名：</td>
                <td>
                    <asp:TextBox ID="stuLoginName" runat="server" Text=""></asp:TextBox></td>
            </tr>
            <tr>
                <td>密码：</td>
                <td>
                    <asp:TextBox ID="stuPwd" runat="server" Text=""></asp:TextBox></td>
            </tr>
            <tr>
                <td>性别：</td>
                <td>
                    <asp:RadioButton ID="rbNan" runat="server" GroupName="sex" />男
                    <asp:RadioButton ID="rbNv" runat="server" GroupName="sex" />女
                </td>
            </tr>
            <tr>
                <td>电话：</td>
                <td>
                    <asp:TextBox ID="stuPhone" runat="server" Text=""></asp:TextBox></td>
            </tr>
            <tr>
                <td>邮箱：</td>
                <td>
                    <asp:TextBox ID="stuEmai" runat="server" Text=""></asp:TextBox></td>
            </tr>
            <tr>
                <td>系别：</td>
                <td>
                    <asp:TextBox ID="stuGrade" runat="server" Text=""></asp:TextBox></td>
            </tr>
        </table>
        <asp:Button ID="AddStudent" runat="server" Text="添加一个学生" OnClick="AddStudent_Click" />
    </div>
</asp:Content>
