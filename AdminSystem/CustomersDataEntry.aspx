<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" width="82px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </div>
        <p>
            <asp:Label ID="lblCustomerName" runat="server" Text="Name" width="82px"></asp:Label>
            <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerEmail" runat="server" Text="Email" width="82px"></asp:Label>
        <asp:TextBox ID="txtCustomerEmail" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblPassword" runat="server" Text="Password" width="82px"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerAddress" runat="server" Text="Address" width="82px"></asp:Label>
        <asp:TextBox ID="txtCustomerAddress" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblDateOfBirth" runat="server" Text="Date Of Birth"></asp:Label>
            <asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkLiveInUK" runat="server" Text="Lives in the UK" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <asp:Label ID="lblError2" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click1" Text="Confirm" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
