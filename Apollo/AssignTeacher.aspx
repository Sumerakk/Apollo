<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin.Master" CodeBehind="AssignTeacher.aspx.cs" Inherits="Apollo.AssignTeacher" %>
<asp:Content ContentPlaceHolderID="Admins" runat="server">
    <div class="section-body">
        <div class="row">
              <div class="col-12">
                    <div class="card">
                         <div class="card-header">
                               <h4>
                                 Teacher Assignment
                               </h4>
                         </div>
                        <div class="card-body">
                            <div class="table-responsive">
                                        <table class="table">
                                            <tr>
                                                <th>
                                                    <label class="col-form-label">Course Name</label>
                                                </th>
                                                <th>
                                                    <label class="col-form-label">Teacher</label>
                                                </th>
                                                <th>
                                                    <label class="col-form-label">Day</label>
                                                </th>
                                                <th>
                                                    <label class="col-form-label">Slot</label>
                                                </th>
                                            </tr>
                                            <tr>
                                                <td>
                                                     <asp:DropDownList ID="coursesname1" runat="server" CssClass="form-control"></asp:DropDownList>
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="teacherlist1" runat="server" CssClass="form-control"></asp:DropDownList>
                                                </td>
                                                <td>
                                                   <asp:DropDownList ID="Day1" runat="server" CssClass="form-control">
                                                       <asp:ListItem>Monday</asp:ListItem>
                                                       <asp:ListItem>Tuesday</asp:ListItem>
                                                       <asp:ListItem>Wednesday</asp:ListItem>
                                                       <asp:ListItem>Thursday</asp:ListItem>
                                                       <asp:ListItem>Friday</asp:ListItem>
                                                    </asp:DropDownList>
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="slot1" runat="server" CssClass="form-control">
                                                        <asp:ListItem>SLOT 1</asp:ListItem>
                                                        <asp:ListItem>SLOT 2</asp:ListItem>
                                                        <asp:ListItem>SLOT 3</asp:ListItem>
                                                        <asp:ListItem>SLOT 4</asp:ListItem>
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                              <tr>
                                                <td>
                                                     <asp:DropDownList ID="coursesname2" runat="server" CssClass="form-control"></asp:DropDownList>
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="teacherlist2" runat="server" CssClass="form-control"></asp:DropDownList>
                                                </td>
                                                <td>
                                                   <asp:DropDownList ID="Day2" runat="server" CssClass="form-control">
                                                       <asp:ListItem>Monday</asp:ListItem>
                                                       <asp:ListItem>Tuesday</asp:ListItem>
                                                       <asp:ListItem>Wednesday</asp:ListItem>
                                                       <asp:ListItem>Thursday</asp:ListItem>
                                                       <asp:ListItem>Friday</asp:ListItem>
                                                   </asp:DropDownList>
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="slot2" runat="server" CssClass="form-control">
                                                        <asp:ListItem>SLOT 1</asp:ListItem>
                                                        <asp:ListItem>SLOT 2</asp:ListItem>
                                                        <asp:ListItem>SLOT 3</asp:ListItem>
                                                        <asp:ListItem>SLOT 4</asp:ListItem>
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                              <tr>
                                                <td>
                                                     <asp:DropDownList ID="coursesname3" runat="server" CssClass="form-control"></asp:DropDownList>
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="teacherlist3" runat="server" CssClass="form-control"></asp:DropDownList>
                                                </td>
                                                <td>
                                                   <asp:DropDownList ID="Day3" runat="server" CssClass="form-control">

                                                       <asp:ListItem>Monday</asp:ListItem>
                                                       <asp:ListItem>Tuesday</asp:ListItem>
                                                       <asp:ListItem>Wednesday</asp:ListItem>
                                                       <asp:ListItem>Thursday</asp:ListItem>
                                                       <asp:ListItem>Friday</asp:ListItem>
                                                   </asp:DropDownList>
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="slot3" runat="server" CssClass="form-control">
                                                        <asp:ListItem>SLOT 1</asp:ListItem>
                                                        <asp:ListItem>SLOT 2</asp:ListItem>
                                                        <asp:ListItem>SLOT 3</asp:ListItem>
                                                        <asp:ListItem>SLOT 4</asp:ListItem>
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                              <tr>
                                                <td>
                                                     <asp:DropDownList ID="coursesname4" runat="server" CssClass="form-control"></asp:DropDownList>
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="teacherlist4" runat="server" CssClass="form-control "></asp:DropDownList>
                                                </td>
                                                <td>
                                                   <asp:DropDownList ID="Day4" runat="server" CssClass="form-control">
                                                       <asp:ListItem>Monday</asp:ListItem>
                                                       <asp:ListItem>Tuesday</asp:ListItem>
                                                       <asp:ListItem>Wednesday</asp:ListItem>
                                                       <asp:ListItem>Thursday</asp:ListItem>
                                                       <asp:ListItem>Friday</asp:ListItem>
                                                   </asp:DropDownList>
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="slot4" runat="server" CssClass="form-control">
                                                        <asp:ListItem>SLOT 1</asp:ListItem>
                                                        <asp:ListItem>SLOT 2</asp:ListItem>
                                                        <asp:ListItem>SLOT 3</asp:ListItem>
                                                        <asp:ListItem>SLOT 4</asp:ListItem>
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            </table>

                        </div>
                            <asp:Button ID="savebtn" Text="Save" CssClass="btn btn-primary btn-lg btn-block" runat="server" />
                        </div>
                  </div>
            </div>
        </div>
      
</asp:Content>