#!/bin/bash

#Check to make sure we passed everything in correctly
if [ ! -n "$2" ] ; then
	echo "Not enough parameters provided. Please try again."
	exit 1
fi

#Where my source at
sourceDir = $1

#where my deploy at
deployDir = $2 

cd $sourceDir

#Build the solution
xbuild

#Clean out the deployDir

rm -rf $deployDir/bin/
rm -rf $deployDir/docs/
rm $deployDir/Global.asax
rm $deployDir/Default.aspx
rm $deployDir/web.config

#deploy some files to 

#reconstruct root
mkdir $deployDir/bin
mkdir $deployDir/docs

cp -ar $sourceDir/BarnMg.Web/bin/*.dll $deployDir/bin/
cp -ar $sourceDir/BarnMg.Web/swagger-ui/* $deployDir/docs/
cp $sourceDir/BarnMg.Web/Global.asax $deployDir
cp $sourceDir/BarnMg.Web/Default.aspx $deployDir
cp $sourceDir/BarnMg.Web/config/web.config $deployDir