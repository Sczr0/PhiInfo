# 可寻址资源
大部分**资源**都使用**可寻址资源**来查找,**不直接保存**在游戏文件/目录里

## 歌曲
每首歌曲资源存放在 `Assets/Tracks/{song_id}` 下  

例如 `Assets/Tracks/Aleph0.LeaF.0` 会有以下内容：  
### Music (音乐)
- `music.wav`

### Illustrations (曲绘文件)
- `Illustration.jpg` – 主封面图
- `IllustrationLowRes.jpg` – 低分辨率封面图
- `IllustrationBlur.jpg` – 模糊封面图

### Charts (谱面文件)
- `Chart_EZ.json`
- `Chart_HD.json`
- `Chart_IN.json`
- `Chart_AT.json`
- `Chart_Legacy.json`

Tip: 大部分歌曲`AT`和`Legacy`难度并不存在
Tip: 冷知识`Random`的`song_id`是`Random.SobremSilentroom.{num}`,并且只存储铺面文件

## 章节封面
`Assets/Tracks/#ChapterCover/{id}.jpg`