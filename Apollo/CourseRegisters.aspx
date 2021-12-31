<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Student.Master" CodeBehind="CourseRegisters.aspx.cs" Inherits="Apollo.CourseRegisters" %>
<asp:Content ContentPlaceHolderID="student" runat="server">
    <div class="section-body">
        <div class="row">
                        <div class="col-12">
                            <div class="card">
                                <div class="card-header">
                                    <h4>
                                        Course Registration
                                    </h4>
                                    </div>
                                <div class="card-body">
                                    <div class="form-group row mb-4">
                                        <label class="col-form-label text-md-right col-12 col-md-3 col-lg-3">Semester</label>
                                        <div class="col-sm-12 col-md-7">
                                            <asp:DropDownList ID="FALL" CssClass="form-control" runat="server" OnSelectedIndexChanged="FALL_SelectedIndexChanged">
                                                <asp:ListItem Text="Spring" Value="Spring">Spring</asp:ListItem>
                                                <asp:ListItem Value="Fall" Text="Fall"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                     </div>
                                    <div class="form-group row mb-4">
                                        <label class="col-form-label text-md-right col-12 col-md-3 col-lg-3">Program</label>
                                        <div class="col-sm-12 col-md-7">
                                              <asp:DropDownList ID="programlist" CssClass="form-control" runat="server" OnSelectedIndexChanged="programlist_SelectedIndexChanged"></asp:DropDownList>
                                        </div>
                                    </div>
                                 </div>
                                <div class="card-header">
                                    <h5>
                                        Core Courses 
                                    </h5>
                                </div>
                                <div class="card-body p-0">
                                    <div class="table-responsive">
                                        <table class="table table-striped v_center">
                                            <tr>
                                                <th>Course Code</th>
                                                <th>Course Name</th>
                                                <th>Course Credit Hours</th>
                                                <th>
                                                    Select 
                                                </th>
                                                <th>Action</th>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Code1" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:Label ID="Name1" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:Label ID="Credit1" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:CheckBox ID="check1" runat="server"></asp:CheckBox>
                                                </td>
                                                <td>
                                                     <asp:Button ID="Drop1" CssClass="btn btn-secondary" runat="server" Text="DROP" OnClick="Drop1_Click"></asp:Button>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Code2" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:Label ID="Name2" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:Label ID="Credit2" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:CheckBox ID="check2" runat="server"></asp:CheckBox>
                                                </td>
                                                <td>
                                                     <asp:Button ID="Drop2" CssClass="btn btn-secondary" runat="server" Text="DROP" OnClick="Drop2_Click"></asp:Button>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Code3" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:Label ID="Name3" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:Label ID="Credit3" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:CheckBox ID="check3" runat="server"></asp:CheckBox>
                                                </td>
                                                <td>
                                                     <asp:Button ID="Drop3" CssClass="btn btn-secondary" runat="server" Text="DROP" OnClick="Drop3_Click"></asp:Button>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Code4" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:Label ID="Name4" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:Label ID="Credit4" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:CheckBox ID="check4" runat="server"></asp:CheckBox>
                                                </td>
                                                <td>
                                                     <asp:Button ID="Drop4" CssClass="btn btn-secondary" runat="server" Text="DROP" OnClick="Drop4_Click"></asp:Button>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Code5" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:Label ID="Name5" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:Label ID="Crdit5" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:CheckBox ID="check5" runat="server"></asp:CheckBox>
                                                </td>
                                                <td>
                                                     <asp:Button ID="Drop5" CssClass="btn btn-secondary" runat="server" Text="DROP" OnClick="Drop5_Click"></asp:Button>
                                                </td>
                                            </tr>
                                         </table>
                                    </div>
                                </div>
    
                                 <div class="card-header">
                                    <h5>
                                        Elective Courses
                                    </h5>
                                </div>
                                <div class="card-body">
                                    <div class="table-responsive">
                                        <table class="table">
                                            <tr>
                                                <th>
                                                    <label class="col-form-label">Sr</label>
                                                </th>
                                                <th>
                                                    <label class="col-form-label">MG Elective</label>
                                                </th>
                                                <th>
                                                    <label class="col-form-label">CS Elective</label>
                                                </th>
                                                <th>
                                                    <label class="col-form-label">SS Elective</label>
                                                </th>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <label class="col-form-label">1</label>
                                                </td>
                                                <td>
                                                     <asp:DropDownList ID="MOG1" CssClass="form-control" runat="server" ></asp:DropDownList>
                                                </td>
                                                <td>
                                                   <asp:DropDownList ID="COS1" CssClass="form-control" runat="server" ></asp:DropDownList>
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="SOS1" CssClass="form-control" runat="server" ></asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <label class="col-form-label">2</label>
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="MOG2" CssClass="form-control " runat="server" ></asp:DropDownList>
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="COS2" CssClass="form-control" runat="server" ></asp:DropDownList>
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="SOS2" CssClass="form-control" runat="server" ></asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <label class="col-form-label">3</label>
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="MOG3" CssClass="form-control" runat="server" ></asp:DropDownList>
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="COS3" CssClass="form-control" runat="server" ></asp:DropDownList>
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="SOS3" CssClass="form-control" runat="server"  ></asp:DropDownList>
                                                </td>
                                            </tr>
                                        </table>
                                  </div>
                                    <div class="form-group row mb-4">
                                        <label class="col-form-label text-md-right col-12 col-md-3 col-lg-3"></label>
                                        <div class="col-sm-12 col-md-7">
                                            <asp:Button CssClass="btn btn-primary btn-lg btn-block" ID="saveButton" Text="Register Course" runat="server" OnClick="saveButton_Click"  />
                                        </div>
                                    </div>
                            </div>
                      </div> 
                 </div>
            </div>
          </div>
</asp:Content>
