# IDE

## vim C#插件安装

***OmniSharp***

https://github.com/OmniSharp/omnisharp-vim
```
Plugin 'OmniSharp/omnisharp-vim'
let g:OmniSharp_server_stdio = 1     //使用ipc方式，而不是http方式来实现功能
let g:OmniSharp_highlight_types = 3  //语法高亮
```

OmniSharp-vim 依赖 OmniSharp-Roslyn server. OmniSharp-Roslyn server 又依赖mono， 因此需要先安装 mono
```
:OmniSharpInstall  // 安装 OmniSharp-Roslyn server
```

let g:ycm_show_diagnostics_ui = 0       // 禁用ycm语法检查，由于ycm关联的C#版本太老，新的语法会报错
map <c-]> :OmniSharpGotoDefinition<CR>  // tags的跳转不够准确

# mono 安装
https://www.mono-project.com/download/stable/#download-lin-centos

# dotnet core 安装
https://docs.microsoft.com/zh-cn/dotnet/core/


# C#学习
https://docs.microsoft.com/zh-cn/dotnet/csharp/

https://docs.microsoft.com/zh-cn/dotnet/csharp/index
