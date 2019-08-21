# Reference properties and ImmediatePostData in ASPxGridView's Batch Edit mode - Early Access Preview v19.2
 
The following features are now supported in List View Batch Edit mode:
- Built-in lookup editors for reference properties. The code-based solution from <a href="https://docs.devexpress.com/eXpressAppFramework/115835/task-based-help/list-editors/how-to-edit-a-reference-property-in-the-batch-edit-mode">How to: Edit a Reference Property in the Batch Edit Mode</a> is no longer required;
- ImmediatePostData works in cell editors.


The demo project from this repository provides several navigation items demonstrating these improvements.

## Lookup editor for reference properties

This item illustrates a simple lookup.

![SimpleDemo](Images/SimpleDemo.gif)

## ImmediatePostData attribute in Batch Edit mode

This item illustrates how the [ImmediatePostData](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.ImmediatePostDataAttribute) attribute works in Batch Edit mode. ListView's calculated properties (FullName, BooleanPropertyAsString, SquaredNumberProperty) are updated immediately after changing values of other cells.

![ImmediatePostData](Images/ImmediatePostData.gif)

## Cascade Filtering for Lookup List Views

The item illustrates how to use [Cascade Filtering for Lookup List Views](https://docs.devexpress.com/eXpressAppFramework/112681/Task-Based-Help/Filtering/How-to-Implement-Cascading-Filtering-for-Lookup-List-Views) in Batch Edit mode. The ListView has two lookup properties: Country and City. The City lookup items are populated based on the value selected in the Country lookup.

![Cascade](Images/Cascade.gif)

## Performance on Large Data Sources
This item shows how the lookup editor handles large data sources. The demonstrated lookup has 100,000 rows and [Server mode](https://docs.devexpress.com/eXpressAppFramework/113683/Concepts/UI-Construction/Views/List-View-Data-Access-Modes) enabled in its model. This feature is available only in Batch Edit mode.

![LargeDataDemo](Images/LargeDataDemo.gif)
