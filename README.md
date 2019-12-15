# Test Build AssetBundle Dependencies

## Usage

`Test1` | `Build1` build `Test1/red`
`Test1` | `Build2` build `Test1/cube`

`Test2` | `Build1` build `Test2/red` and `Test2/cube`

The files in `Test1` and `Test2` are the same.

So different assetbundle could be distributed to different Unity process to build.
