<%@ Page Title="" Language="C#" MasterPageFile="~/View/TeacherMain.Master" AutoEventWireup="true" CodeBehind="StudentPage.aspx.cs" Inherits="MyExamSystem.View.StudentPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table class="table table-bordered table-hover">
            <tr>
                <td>ID</td>
                <td>姓名</td>
                <td>登录名</td>
                <td>性别</td>
                <td>电话</td>
                <td>邮箱</td>
                <td>系别</td>
                <td>操作</td>
            </tr>
            <asp:Repeater ID="Repeate1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("StuID") %></td>
                        <td><%#Eval("StuName") %></td>
                        <td><%#Eval("StuLoginName") %></td>
                        <td><%#Eval("StuSex") %></td>
                        <td><%#Eval("StuPhone") %></td>
                        <td><%#Eval("StuEmail") %></td>
                        <td><%#Eval("StuGrade") %></td>
                        <td>
                            <a href="#" class="btn btn-success">编辑</a>
                            <a href="#" class="btn btn-success">详情</a>
                            <asp:Button ID="Button1" runat="server" Text="删除" />
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
        <asp:Button ID="AddStudent" runat="server" Text="添加学生" />
    </div>
</asp:Content>
