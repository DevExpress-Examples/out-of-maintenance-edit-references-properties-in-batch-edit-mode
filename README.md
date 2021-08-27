<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/202139404/19.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828548)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# OBSOLETE: In v19.2+, the List View's Batch Edit mode supports built-in lookup editors for reference properties. The custom code from this example is no longer required.


===========

# Reference properties and ImmediatePostData in ASPxGridView's Batch Edit mode

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
