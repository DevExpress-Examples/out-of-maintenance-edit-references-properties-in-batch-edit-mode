# Support reference properties in ASPxGridView's Batch Edit mode - Early Access Preview v19.2

We've supported reference properties in ASPxGridView's Batch Edit mode without custom code since v19.2. This demo demostrates the new functionality.

There are four navigation items:

## SimpleDemo:

This demo illustrates simple lookup property in ASPxGridView's Batch Edit mode

![SimpleDemo](Images/SimpleDemo.gif)

## ImmediatePostData:

The [ImmediatePostData](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.ImmediatePostDataAttribute) attribute is supported in the Batch Edit mode. This demo shows immediately update calculated properties (FullName, BooleanPropertyAsString, SquaredNumberProperty) after changing the primary properties.

![ImmediatePostData](Images/ImmediatePostData.gif)

## Cascade:

The [Cascading Filtering for Lookup List Views](https://docs.devexpress.com/eXpressAppFramework/112681/Task-Based-Help/Filtering/How-to-Implement-Cascading-Filtering-for-Lookup-List-Views) is supported. This demo illustrates cascade properties: Country and City. The City lookup is dynamically populated with city names based on the value selected in the Country lookup.

![Cascade](Images/Cascade.gif)

## LargeDataDemo:
This demo shows the performance of ASPxGridView with the lookup contains 100000 rows. [The Server mode](https://docs.devexpress.com/eXpressAppFramework/113683/Concepts/UI-Construction/Views/List-View-Data-Access-Modes) is enabled for the Lookup ListView.

![LargeDataDemo](Images/LargeDataDemo.gif)
