# Skydiving Dropzone
Copyright (c) 2019 Yufei Tao Ian Gaul

# Description
The goal of this project is to provide an open source cross platform (iphone/android) mobile
app for skydivers. This app can help skydivers to log their jumps. Users can store gear and 
aircraft profiles along with logging jump data on their phone and export the logbook to computer or cloud.

In additon to the logbook, users can also find nearby skydiving dropzones and view
current weather and wind conditions at the jumpsite.


## Install and build
	Note: You will need Apple hardware to run and test iPhone version. IPhone requires apps be
	installed from their app store.	There are not current plans to release this app through the
	app store. Though this project is under MIT license, some products involved require accepting
	other terms and conditions.
	
Building this project is recommended using [Visual Studio](https://visualstudio.microsoft.com/vs/) on iOS or Windows. [Some Linux options available](https://www.monodevelop.com/)

- Clone this repo
- Open `SkydivingDropzone/Dropzone.sln` in VS
- Click Build ( allow VS to download packages, such as xamarin, if not currently installed )

[Load to android](https://github.com/YufeiT/SkydivingDropzone)


## Tests
(need to be updated)

## License

This program is licensed under the "MIT License".  Please
see the file [LICENSE](https://github.com/YufeiT/SkydivingDropzone/blob/master/LICENSE) in the source distribution of this
software for license terms.

#### Todo

- [ ] map with saved pins
- [ ] weather lists, saves
- [ ] wind data
- [ ] logbook 
	- [x] db
	- [x] add entry page
- [x] edit profile page
- [ ] useful links (USPA, etc)


#### Special thanks
To the Mono and Xamarin communities and Edward Rosas' Xamarin course

