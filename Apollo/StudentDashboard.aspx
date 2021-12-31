<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Student.Master" CodeBehind="StudentDashboard.aspx.cs" Inherits="Apollo.StudentDashboard" %>
<asp:Content ContentPlaceHolderID="student" runat="server">
     <div class="section-body">
        <!--<h2 class="section-title">Student Profile</h2>    -->
        <div class="row">
                        <div class="col-12">
                            <div class="card">
                                <div class="card-header">
                                    <h2>
                                        Student Profile
                                    </h2>
                                </div>
                                    <div class="card-header">
                                    <h4>Personal Information</h4>
                                    </div>
                                 <div class="card-body">
                                    <div class="form-group row mb-4">
                                        <label class="col-form-label text-md-right col-12 col-md-3 col-lg-3">Name</label>
                                        <div class="col-sm-12 col-md-7">
                                            <asp:TextBox ID="nametext" type="text" Text="Sumera Khan" CssClass="form-control" runat="server" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group row mb-4">
                                        <label class="col-form-label text-md-right col-12 col-md-3 col-lg-3">DOB</label>
                                        <div class="col-sm-12 col-md-7">
                                            <asp:TextBox ID="dobtext" type="text" Text="0000/00/00" CssClass="form-control datemask" ReadOnly="true" placeholder="YYYY/MM/DD" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group row mb-4">
                                        <label class="col-form-label text-md-right col-12 col-md-3 col-lg-3">Gender</label>
                                        <div class="col-sm-12 col-md-7">
                                            <asp:TextBox ID="gendertext" type="text" Text="Female" CssClass="form-control" ReadOnly="true" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group row mb-4">
                                        <label class="col-form-label text-md-right col-12 col-md-3 col-lg-3">CNIC</label>
                                        <div class="col-sm-12 col-md-7">
                                            <asp:TextBox ID="cnictext" type="text" Text="00000-0000000-0" CssClass="form-control" ReadOnly="true" runat="server"></asp:TextBox>
                                        </div>
                                    </div><div class="form-group row mb-4">
                                        <label class="col-form-label text-md-right col-12 col-md-3 col-lg-3">Email</label>
                                        <div class="col-sm-12 col-md-7">
                                            <asp:TextBox ID="emailtext" type="text" Text="K201523@nu.edu.pk" CssClass="form-control" ReadOnly="true" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="card-header">
                                    <h4>University Detail</h4>
                                    </div>
                                <div class="card-body">
                                    <div class="form-group row mb-4">
                                        <label class="col-form-label text-md-right col-12 col-md-3 col-lg-3">University Name</label>
                                        <div class="col-sm-12 col-md-7">
                                            <asp:TextBox ID="uniname" type="text" Text="FAST" CssClass="form-control" runat="server" ReadOnly="True"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group row mb-4">
                                        <label class="col-form-label text-md-right col-12 col-md-3 col-lg-3">Degree</label>
                                        <div class="col-sm-12 col-md-7">
                                            <asp:TextBox ID="degree" type="text" Text="BSCS Hons" CssClass="form-control" runat="server" ReadOnly="True"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group row mb-4">
                                        <label class="col-form-label text-md-right col-12 col-md-3 col-lg-3">Section</label>
                                        <div class="col-sm-12 col-md-7">
                                            <asp:TextBox ID="section" type="text" Text="A" CssClass="form-control" runat="server" ReadOnly="True"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group row mb-4">
                                        <label class="col-form-label text-md-right col-12 col-md-3 col-lg-3">Campus</label>
                                        <div class="col-sm-12 col-md-7">
                                            <asp:TextBox ID="campus" type="text" Text="Karachi" CssClass="form-control" runat="server" ReadOnly="True"></asp:TextBox>
                                        </div>
                                    </div>
                                    </div>

                                </div>
                            </div>
            </div>
         </div>
</asp:Content>
