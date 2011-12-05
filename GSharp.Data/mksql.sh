#!/bin/sh

/usr/bin/sqlmetal --debug /namespace:GSharp.Data /provider=Sqlite "/conn:Data Source=../GSharp.db3" /code:DB.cs
