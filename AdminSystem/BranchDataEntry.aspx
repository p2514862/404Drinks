<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BranchDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="BranchId" runat="server" Text="Branch Id"></asp:Label>
&nbsp;<asp:TextBox ID="txtBranchId" runat="server"></asp:TextBox>
        <p style="width: 77px">
            Satff Id
            <asp:TextBox ID="txtStaffId" runat="server" style="margin-left: 86px" Width="168px"></asp:TextBox>
        </p>
        <p style="width: 77px">
            Product Id
            <asp:TextBox ID="txtProductId" runat="server" style="margin-left: 79px"></asp:TextBox>
        </p>
        <p style="width: 77px">
            Branch Start Date&nbsp;
            <asp:TextBox ID="txtBranchStartDate" runat="server" style="margin-left: 74px"></asp:TextBox>
        </p>
        <p style="width: 77px">
            Branch Description
            <asp:TextBox ID="txtBranchDescription" runat="server" style="margin-left: 72px"></asp:TextBox>
        </p>
        
        <p>
            <asp:CheckBox ID="chkIsStaffAvailable" runat="server" Text="Staff is available" />
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
