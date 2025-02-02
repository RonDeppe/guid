<h1 align="center">GUID</h1>

<h5 align="center">Command-line tool for generating GUIDs</h5>

<p align="center">
  <a href="https://github.com/RonDeppe/guid/releases">
        <img src="https://img.shields.io/github/v/release/RonDeppe/guid?logo=github" alt="Latest Release">
    </a>
    <a href="https://github.com/RonDeppe/guid/blob/main/LICENSE">
        <img src="https://img.shields.io/github/license/RonDeppe/guid" alt="License">
    </a>
  <a href="https://github.com/RonDeppe?tab=repositories&q=&type=&language=c%23&sort=">
        <img src="https://img.shields.io/github/languages/top/RonDeppe/guid" alt="Top Language">
    </a>
</p>

GUID is a lightweight command-line tool written in <code>C#</code> that generates GUIDs with customizable options, such as specifying the number of GUIDs, choosing a separator, or removing the dashes (`-`).


## Instalation
1. Dowload the program directly from [the GitHub releases page](https://github.com/RonDeppe/guid/releases/latest).
2. Add a folder for scripts to your PATH variable. Usually this is `C:\Users\{Username}\bin`.
3. Place `guid.exe` in this folder.

## Usage
### Running the Program
To run the program, simply execute the following command in the terminal:
```ps
guid.exe
```

### Generating Multiple GUIDs
To generate a specific number of GUIDs, use the `--amount` flag followed by the desired count:
```shell
guid.exe --amount 5
```
Example output:
```
b5d698c3-da58-42fb-a0fa-2d622a34ba1b
39f07753-0546-4554-a677-ea8df70e5f91
cc2b06bc-0e9d-4599-a54b-169437b98f45
f8e9d3b8-5730-4de8-b8ed-c3c09b6711d5
600da461-f709-40ce-a235-7cf13b8c3607
```

### Customizing Separators
You can customize the separator between GUIDs using the `--separator` flag, followed by the desired characters. Here are a few examples:
1. Using `*\n` as a separator:
```ps
guid.exe --amount 3 --separator *\n
```
Example output:
```
038f388a-0b74-4f79-9b98-260488efb68a*
b66ed1e5-7c74-4af0-9692-11c5d3048294*
ce97871e-a008-4808-b0d0-5676836fa076
```
2. Using `@` as a separator:
```ps
guid.exe --amount 3 --separator @
```
Example output:
```
789c8c13-dd32-499d-9eab-91d8cd2592d5@5f57aa4a-d34b-4ac8-bb40-edbbf1446417@ba5b9842-cfe6-4a5b-a315-2c17956bba20
```

3. Using `" # "` as a separator:
```ps
guid.exe --amount 3 --separator " # "
```
Example output:
```
3671d154-a86b-4f99-af31-956f313323c3 # 15092173-28f8-4f4d-9312-d0158d8cc8d1 # 3e5db697-a09d-4413-ab53-2b024acc697d
```

### Compact Format
To generate GUIDs without dashes (`-`), use the `-c` flag:
```ps
guid.exe -c
```
Example output:
```
66d1c7b6301b49c8b28c9921a07779c2
```

## FAQ
### Q: What platforms are supported
Currently only windows 11 has been tested, but other systems and older versions of windows should work.
