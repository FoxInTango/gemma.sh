#!/usr/bin/bash
shell_cmd=$(basename $0)
shell_dir=$(dirname  $0)
shell_pwd=$(pwd)

. ${shell_dir}/include/headers

<< eof
fs.blk
fs.chext
fs.chnam
fs.find
fs.traversal
fs.uuid
eof

function travel_fs() {
for element in `ls $1`; do
    node=$1"/"${element}
    if [ -d ${node} ]; then
        chmod ${node} 755
        travel_fs $node
    else
        chmod 644 ${node}
        echo ${node}
    fi
    done
}

travel_fs ${shell_pwd}
