<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffID" runat="server" Text="StaffID" height="22px" width="121px"></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server" Height="16px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <p>
            <asp:Label ID="lblBranchID" runat="server" Text="BranchID" height="22px" width="121px"></asp:Label>
            <asp:TextBox ID="txtBranchID" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblFullName" runat="server" Text="FullName" height="22px" width="121px"></asp:Label>
        <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblDOB" runat="server" Text="DOB" height="22px" width="121px"></asp:Label>
        <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email" height="22px" width="121px"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblMonthlyS" runat="server" Text="MonthlySalary "></asp:Label>
        <asp:TextBox ID="txtMonthlyS" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkOnHoliday" runat="server" Text="OnHoliday" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
