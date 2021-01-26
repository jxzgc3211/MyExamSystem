<%@ Page Title="" Language="C#" MasterPageFile="~/View/TeacherMain.Master" AutoEventWireup="true" CodeBehind="StudentPage.aspx.cs" Inherits="MyExamSystem.View.StudentPage"%>

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
            <asp:Repeater ID="Repeate1" runat="server" OnItemCommand="Repeate1_ItemCommand">
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
                            <a href="StudentModify.aspx?stuId=<%#Eval("StuID")%>" class="btn btn-success">编辑</a>
                            <%--当点击“详情”的使用，应该把当前行的学生id传到详情页,通过Eval函数传递参数--%>
                            <a href="StudentDetail.aspx?stuId=<%#Eval("StuID")%>" class="btn btn-success">详情</a>
                            <%--当点击“删除按钮”时，应获取到对应行的编号--%>
                            <asp:Button ID="Button1" runat="server" Text="删除" CssClass="btn btn-danger" CommandName="del" CommandArgument='<%#Eval("StuID") %>' />
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
       <a href="AddStudent.aspx" class="btn btn-success">添加新学生</a>
    </div>
</asp:Content>
