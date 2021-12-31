<%@ Page Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="EditCourse.aspx.cs" Inherits="Apollo.EditCourse" %>
<asp:Content ContentPlaceHolderID="Admins" runat="server">
     <div class="section-body">
     
        
        <h2 class="section-title">ADD COURSE</h2>
        
        <div class="row">
                        <div class="col-12">
                            <div class="card">
                                <div class="card-header">
                                    <h4>Course Detail</h4>

                                    <div style="padding-left:650px;">
                                        <asp:Button ID="filebutton" Text="IMPORT" CssClass="btn btn-primary" runat="server" OnClick="filebutton_Click" />
                                    </div>
                                </div>
                                <div class="card-body">
                                    <div class="form-group row mb-4">
                                        <label class="col-form-label text-md-right col-12 col-md-3 col-lg-3">Course Code</label>
                                        <div class="col-sm-12 col-md-7">
                                            <asp:TextBox ID="CourseCode" type="text" CssClass="form-control" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group row mb-4">
                                        <label class="col-form-label text-md-right col-12 col-md-3 col-lg-3">Course Name</label>
                                        <div class="col-sm-12 col-md-7">
                                            <asp:TextBox ID="coursename" type="text" CssClass="form-control" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group row mb-4">
                                        <label class="col-form-label text-md-right col-12 col-md-3 col-lg-3">Course Credit Hours</label>
                                        <div class="col-sm-12 col-md-7">
                                            <asp:TextBox ID="CourseCreditHours" type="text" CssClass="form-control" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group row mb-4">
                                        <label class="col-form-label text-md-right col-12 col-md-3 col-lg-3">Course Pre Requiste Code</label>
                                        <div class="col-sm-12 col-md-7">
                                            <asp:TextBox ID="coursepcode" type="text" CssClass="form-control" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group row mb-4">
                                        <label class="col-form-label text-md-right col-12 col-md-3 col-lg-3">Effective Date Start</label>
                                        <div class="col-sm-12 col-md-7">
                                            <asp:TextBox ID="effctst" type="text" CssClass="form-control datemask" placeholder="YYYY/MM/DD" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group row mb-4">
                                        <label class="col-form-label text-md-right col-12 col-md-3 col-lg-3">Effective Date End</label>
                                        <div class="col-sm-12 col-md-7">
                                            <asp:TextBox ID="effcten" type="text" CssClass="form-control datemask" placeholder="YYYY/MM/DD" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group row mb-4">
                                        <label class="col-form-label text-md-right col-12 col-md-3 col-lg-3">Course Type</label>
                                        <div class="col-sm-12 col-md-7">
                                            <asp:DropDownList ID="CourseTypelist" CssClass="form-control" runat="server">
                                                <asp:ListItem>Core</asp:ListItem>
                                                <asp:ListItem>Elective</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="form-group row mb-4">
                                        <label class="col-form-label text-md-right col-12 col-md-3 col-lg-3">Program Name</label>
                                        <div class="col-sm-12 col-md-7">
                                            <asp:DropDownList ID="prgramlist" CssClass="form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </div>
                                    </div>
                     </div>
                 </div>
            </div>
         </div>
   
</asp:Content>
