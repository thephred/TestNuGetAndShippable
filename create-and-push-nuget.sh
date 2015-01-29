#!/bin/sh

rm -f *.nupkg
sed -i'' 's/\[BUILD_NUMBER\]/'"$BUILD_NUMBER"'/' TestNuGetAndShippable.nuspec
mono nuget.exe pack TestNuGetAndShippable.nuspec
mono nuget.exe push TestNuGetAndShippable.*.nupkg $MYGET_APIKEY -Source https://www.myget.org/F/thephred-test/api/v2/package
