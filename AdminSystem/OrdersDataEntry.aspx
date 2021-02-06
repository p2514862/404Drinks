<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    This is the orders entry page.
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderID" runat="server" Text="Order ID" width="182px"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCutomerID" runat="server" Text="Customer ID" width="182px"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblProductID" runat="server" Text="Product ID" width="182px"></asp:Label>
        <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblDateOfPurchase" runat="server" Text="Date of purchase" width="182px"></asp:Label>
        <asp:TextBox ID="txtDateOfPurchase" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblTotalPrice" runat="server" Text="TotalPrice" width="182px"></asp:Label>
        <asp:TextBox ID="txtTotalPrice" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblShippingCompany" runat="server" Text="Shipping Company" width="182px"></asp:Label>
        <asp:TextBox ID="txtShippingCompany" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkOver18" runat="server" Text="Over 18?" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
