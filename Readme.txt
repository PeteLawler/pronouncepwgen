KeePass Pronounceable Password Generator
Copyright (c) 2009 Jan Benjamin Engracia <jaybz.e@gmail.com>

This is a plugin for KeePass that allows generation of pronounceable passwords.
The pronounceability rules used by this plugin have been based on FIPS 181.

The plugin code itself came from another project I created; pwgenlib.net.  It
is being developed in parallel to this plugin and related improvements to
either project will be reflected on both.  You can find pwgenlib.net here:
<http://bitbucket.org/jaybz/pwgenlibnet/overview/>

REQUIREMENTS

As of this writing, the version required for this plugin to work has not yet
been released, however, this plugin should work with any version later than
2.07b.

INSTALLING

Just copy PronouncePwGen.dll to the same directory where KeePass.exe is located
and KeePass should automatically recognize and load the plugin.

USAGE

In the password generation menu, the Pronounceable Password Generator option
should appear in the custom algorithm drop down box.  Just select it and click
on the options button beside the drop down box if you wish to change the
password generation settings.

NOTES

The plugin will always generate passwords at least as long as the specified
minimum length.  It will stop adding syllables as soon as it reaches or exceeds
the minimum length.

When the Use Digits option is checked, the plugin includes digits in between
syllables and at the end of the password only.  This allows the digits to be
added without decreasing the memorizability of the password too much.
