The [Data Grid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1) component allows you to build hierarchical layouts of any complexity and depth. This demo module illustrates how to use a nested grid component to visualize a master-detail relationship between two data tables. To do this, follow the steps below.

1.  Add the master grid to your application.
2.  Bind the master grid to data and enable its [ShowDetailRow](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.ShowDetailRow) property to display detail rows.
3.  Add the master grid's columns to the [Columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.Columns) collection.
4.  Create the detailed view. Add the second data grid to the master grid's [DetailRowTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.DetailRowTemplate) and bind this grid to a detail data source that uses the template's **context** object as a filter criterion.
5.  (Optional) To collapse an expanded detail row when a new detail row is displayed, set the [AutoCollapseDetailRow](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.AutoCollapseDetailRow) property to **true**.
6.  Specify the [key data field](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.KeyFieldName) to enable the Data Grid to identify individual data items.

YouTube Video: [Master-Detail Layout](https://www.youtube.com/watch?v=dndSUsg1i7U&feature=youtu.be)
