This project is intended to exhibit incompatibilities between .NET's (legacy) XML serialization and member-level assembly trimming.

At the time of writing, most of the XML serialization methods are attributed with "RequiresUnreferencedCode" which is linked to warning-severity code rules.

Whether or not .NET's built-in XML serializers will switch from reflection to code generation (a la `System.Text.Json`) is T.B.D.
