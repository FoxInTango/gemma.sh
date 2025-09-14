Here Document
https://www.examplecode.cn/post/7331400984662801/replace-shell-variables-in-text-files
cat << EOF > output.txt
Hello, ${NAME}!
Your email is: ${EMAIL}.
EOF

https://www.baeldung.com/linux/substitute-variables-text-file
    envsubst 
   https://cn.linux-console.net/?p=14780#google_vignette

sed
https://askubuntu.com/questions/662559/replace-text-in-file-with-variable-using-sed

https://www.systutorials.com/how-to-unexport-an-exported-variable-in-bash-on-linux/
export -n MODE 
unset MODE

\n\r

https://www.cnblogs.com/wangxuan0321/p/13437743.html

vim 通过:set ff 查看脚本格式，如果fileformat=dos，使用:set ff=unix更改脚本格式，后:wq!，再次执行该shell脚本即可。
fetal: update_ref failed for ref 'ORIG_HEAD': cannot lock ref 'ORIG_HEAD': unable to resolve reference 'ORIG_HEAD': reference broken
