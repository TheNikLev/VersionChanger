## VersionChangerClient

nik9 is the original creator of this stuff -> https://thunderstore.io/package/nik9/VersionSwapper/

tho i tested their mod and it didn't work and yielded "NullReferenceException: Object reference not set to an instance of an object" cause like ahaahahha he quite messed up with Logger

so i decided to rewrite this mess

also their original code didn't compile for me, cause they were somehow directly changing the value of RoR2Application's "private static buildId" from this class, and VisualStudio just said "no lol, that's illegal"
