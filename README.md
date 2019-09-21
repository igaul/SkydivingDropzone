# Skydiving Dropzone
Copyright (c) 2019 Yufei Tao Ian Gaul

# Build Status
![bitrise](https://app.bitrise.io/app/392d655d1c0b770a/status.svg?token=gry1j19c_cU9yh5LC8LAXw&branch=master)

# Description
The goal of this project is to provide an open source cross platform (iphone/android) mobile
app for skydivers. This app can help skydivers to log their jumps. Users can store gear and 
aircraft profiles along with logging jump data on their phone and export the logbook to computer or cloud.

In additon to the logbook, users can also find nearby skydiving dropzones and view
current weather and wind conditions at the jumpsite.

## Examples

![data screenshot](https://github.com/YufeiT/SkydivingDropzone/blob/master/screenshots/ss13%20at%2007.11.58.png)
![data screenshot](https://github.com/YufeiT/SkydivingDropzone/blob/master/screenshots/ss13%20at%2007.12.03.png)
![data screenshot](https://github.com/YufeiT/SkydivingDropzone/blob/master/screenshots/ss13%20at%2007.12.41.png)
![data screenshot](https://github.com/YufeiT/SkydivingDropzone/blob/master/screenshots/ss13%20at%2007.13.23.png)
![data screenshot](https://github.com/YufeiT/SkydivingDropzone/blob/master/screenshots/ss13%20at%2007.13.35.png)
![data screenshot](https://github.com/YufeiT/SkydivingDropzone/blob/master/screenshots/ss13%20at%2007.14.04.png)
![data screenshot](https://github.com/YufeiT/SkydivingDropzone/blob/master/screenshots/ss13%20at%2007.14.11.png)
![data screenshot](https://github.com/YufeiT/SkydivingDropzone/blob/master/screenshots/ss13%20at%2007.14.54.png)



## Install and build
	Note: You will need Apple hardware to run and test iPhone version. IPhone requires apps be
	installed from their app store.	This app is not currently published through the
	app store. Though this project is under MIT license, some products involved require accepting
	other terms and conditions.
	
Building this project is recommended using [Visual Studio](https://visualstudio.microsoft.com/vs/) on iOS or Windows. [Some Linux options available](https://www.monodevelop.com/)

- Clone this repo
- Open `SkydivingDropzone/Dropzone.sln` in VS
- Click Build ( allow VS to download packages, such as xamarin, if not currently installed )

[Load to android](https://github.com/YufeiT/SkydivingDropzone)


## Tests
Currently passing. Need refactor for next state. Using Nunit.

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
- [ ] points of interest with pop out information window 
- [ ] map saving
- [ ] map zoom levels
- [ ] Gear/aircraft dropdown picker
- [ ] data export
- [ ] signatures
- [ ] Autofill suggested
- [ ] ...
- [ ] Deploy to Apple and Play stores


#### Special thanks
To the Mono and Xamarin communities and Edward Rosas' Xamarin course

