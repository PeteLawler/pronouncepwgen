KeePass Pronounceable Password Generator
Copyright (c) 2009 Jan Benjamin Engracia <jaybz.e@gmail.com>

This is a plugin for KeePass that allows generation of pronounceable passwords.
The pronounceability rules used by this plugin have been based on FIPS 181.

The plugin code itself came from another project I created; pwgenlib.net.  It
is being developed in parallel to this plugin and related improvements to
either project will be reflected on both.  You can find pwgenlib.net here:
<http://bitbucket.org/jaybz/pwgenlibnet/overview/>

REQUIREMENTS

This plugin requires KeePass 2.08 available at <http://keepass.info/>.

INSTALLING

Just copy PronouncePwGen.plgx to the same directory where KeePass.exe is located
and KeePass should automatically recognize and load the plugin.

USAGE

In the password generation menu, the Pronounceable Password Generator option
should appear in the custom algorithm drop down box.  Just select it and click
on the options button beside the drop down box if you wish to change the
password generation settings.

SUBSTITUTION SCHEMES

Substituiton schemes are defined by creating text files in <path to keepass>\ppgusb
using an extension of .ppgsub.  Each substitution rule is defined like this:

<character to replace>=<replacement text>

Here are the rules for creating a substitution scheme:
- One rule per line.
- If multiple rules are defined to replace the same character, only the first
  rule will be applied.  The rest will be ignored.
- Only one character may be replaced at a time but the replacement text can have
  more than 1 character.
- No spaces must be included before the = symbol or before the character to be
  replaced.
- Any spaces immediately after the = symbol and trailing the line will be
  treated as part of the replacement text.
- An empty replacement can also be used to explicitly remove specific characters
  from the password, however, doing this for letters will likely reduce
  pronounceability.
- All invalid lines will be ignored without error messages.  This effect can be
  taken advantage of to include comments in the substitution scheme file.
- The defined character to replace is not case sensitive, however, the
  replacement will be applied after the case randomization options and will
  therefore be included as is without any case modifications.  This effect,
  allows you to create substitution schemes to capitalize specific letters in
  the resulting password.

CHANGES (moved to Changes.txt)

CREDITS

Many thanks to Dominik Reichl for creating KeePass Password Safe, without which,
this plugin would not exist and my life would have been much more difficult.

I would also like to extend my thanks to the creator of the "Nuvola" icon set,
David Vignioni.  For more information, please refer to the included original
readme and license.

SUPPORT

Questions should go to the SourceForge forum for KeePass Pronounceable Password
Generator Plugin.
