<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin.Master" CodeBehind="StudentCoursesection.aspx.cs" Inherits="Apollo.StudentCoursesection" %>
<asp:Content ContentPlaceHolderID="Admins" runat="server">
     <div class="section-body">
     
        
        <h2 class="section-title">Student Course Section</h2>
        
        <div class="row">
                        <div class="col-12">
                            <div class="card">
                                <div class="card-header">
                                    <h4>Student Details</h4>

                                    <div style="padding-left:350px;">
                                        <div class="form-group row mb-4">
                                         <asp:TextBox ID="RegNumber" type="text" CssClass="form-control" placeholder="Student Roll Number to search" runat="server"></asp:TextBox>
                                        <div class="col-sm-12 col-md-7">
                                              <asp:Button ID="filebutton" Text="Search Student" CssClass="btn btn-primary" runat="server"/>
                                        </div>
                                      </div>                                        
                                </div>
                             </div>

                                <div class="card-body">
                                    <div class="form-group row mb-4">
                                        <label class="col-form-label text-md-right col-12 col-md-3 col-lg-3">Student Name</label>
                                        <div class="col-sm-12 col-md-7">
                                            <asp:TextBox ID="stname" type="text" Text="Ali Ghous" CssClass="form-control" ReadOnly="true" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="card-header">
                                        <h4>
                                            Courses Enrolled
                                        </h4>
                                    </div>
                                    <div class="table-responsive">
                                        <table class="table">
                                            <tr>
                                                <th>
                                                   <label class="col-form-label">Course Name</label>
                                                </th>
                                                <th>
                                                   <label class="col-form-label">Course Section</label>
                                                </th>
                                            </tr>
                                            <tr>
                                                <td>
                                                   <label class="col-form-label">Course Name1</label>
                                                </td>
                                                <td>
                                                   <asp:TextBox CssClass="form-control" ID="coursename1" runat="server"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:Button ID="changebtn1" Text="Change Section" CssClass="btn btn-primary" runat="server"/>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                   <label class="col-form-label">Course Name2</label>
                                                </td>
                                                <td>
                                                   <asp:TextBox CssClass="form-control" ID="coursename2" runat="server"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:Button ID="changebtn2" Text="Change Section" CssClass="btn btn-primary" runat="server"/>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                   <label class="col-form-label">Course Name3</label>
                                                </td>
                                                <td>
                                                   <asp:TextBox CssClass="form-control" ID="coursename3" runat="server"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:Button ID="changebtn3" Text="Change Section" CssClass="btn btn-primary" runat="server"/>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                   <label class="col-form-label">Course Name4</label>
                                                </td>
                                                <td>
                                                   <asp:TextBox CssClass="form-control" ID="coursename4" runat="server"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:Button ID="chnagebtn4" Text="Change Section" CssClass="btn btn-primary" runat="server"/>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                   <label class="col-form-label">Course Name5</label>
                                                </td>
                                                <td>
                                                   <asp:TextBox CssClass="form-control" ID="coursename5" runat="server"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:Button ID="changebtn5" Text="Change Section" CssClass="btn btn-primary" runat="server"/>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                   <label class="col-form-label">Course Name6</label>
                                                </td>
                                                <td>
                                                   <asp:TextBox CssClass="form-control" ID="coursename6" runat="server"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:Button ID="changebtn6" Text="Change Section" CssClass="btn btn-primary" runat="server"/>
                                                </td>
                                            </tr>
                                            </table>
                                        </div>
                                </div>



                   </div>
            </div>
         </div>
         </div>

</asp:Content>