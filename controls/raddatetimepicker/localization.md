---
title: Localization
page_title: Localization
description: Localization
slug: raddatetimepicker-localization
tags: localization
published: True
position: 6
---

# Localization

The built-in localization mechanism in Silverlight and WPF allows you to localize any string resource used by the RadDateTimePicker control. Once translated, you might use your resources in both Silverlight and WPF projects without changing anything.      	

>tipTo learn more about the ways to localize the RadControls please read the common topic about {% if site.site_name == 'Silverlight' %}[Localization](http://www.telerik.com/help/silverlight/common-localization.html){% endif %}{% if site.site_name == 'WPF' %}[Localization](http://www.telerik.com/help/wpf/common-localization.html){% endif %}.       	

In __RadDatetimePicker__ you can localize the Enter date message, Close link and  Error tooltip:

![datetimepicker localization 1](images/datetimepicker_localization_1.png)

![datetimepicker localization 2](images/datetimepicker_localization_2.png)

The next images show the DateTimePicker localized in French:

![datetimepicker localization 3](images/datetimepicker_localization_3.png)

![datetimepicker localization 4](images/datetimepicker_localization_4.png)

>The days of the week and months are automatically localized by the DateTime class using the current culture settings of the application.
        	

## Resource Keys    
   
The resources of the control can be localized by using an unique identifier called resource key that is assigned to each localizable string. Below you may find a list of the Resources available and their default values:    	
		
Key | Value
---|---
Close | Close 
EnterDate | Enter Date 
Error | Error