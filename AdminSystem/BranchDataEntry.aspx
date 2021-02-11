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
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p style="width: 77px">
            Satff Id
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 86px" Width="168px"></asp:TextBox>
        </p>
        <p style="width: 77px">
            Product Id
            <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 79px"></asp:TextBox>
        </p>
        <p style="width: 77px">
            Branch Start Date&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 74px"></asp:TextBox>
        </p>
        <p style="width: 77px">
            Branch Description
            <asp:TextBox ID="txtBranchDescription" runat="server" style="margin-left: 72px"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="IsStaffAvailable" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Available" />
        </p>
        [lblError]<p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
