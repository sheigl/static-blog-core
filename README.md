# Static Blog Core
Static blogging software made with .NET Core.

# Purpose
Create and maintain a blog using static html pages. This app will allow you to store all blog entries, site files, etc locally and publish changes or a full site to a remote server or folder.
This removes the security risk of having a backend admin piece exposed to the outside world and improves speed of the site. The application maintains and rebuilds all site html / css.

# Project Breakdown
## Stand alone client to publish
1. Web based (run locally or on a secure server not accessible to outside world)
2. Click to publish single post or rebuild entire site
3. Push post, publish site

## Templated
1. Templated html generation, possible using mustasch sharp
2. Templated css
3. Ability to change and create custom templates
4. Change css frameworks

## Menu System
1. Ability to create and change the menu

## Blogging Features
1. Categories
2. Tags
3. Posts
4. Comments? 3rd party js?

## User management
1. Users are handled offline, using the app locally when publishing
2. How to handle remote publishing?
3. No need for OAuth etc since offline
