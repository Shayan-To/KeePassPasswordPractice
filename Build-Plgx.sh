#!/bin/bash

fail()
{
	echo "${2-An error occured.}"
	echo
	read -rsn 1 -p "Press any key to continue..."
	exit $1
}

[ -z "$(git status --untracked-files=no --porcelain)" ] || fail 2 "Working directory not clean."

temp_dir='/tmp/KeePassPasswordPractice-Build-Plgx'
version="$(cat keepass.version | sed -n '2s/.*://p')" || fail 1

rm -rf "$temp_dir" || fail 1

git clone . "$temp_dir" || fail 1
rm -r "$temp_dir/.git" "$temp_dir/Doc" || fail 1

../KeePass-Binaries/KeePass.exe --plgx-create "$(cygpath -w "$temp_dir")" || fail 1

rm -r "$temp_dir" || fail 1
mv "$temp_dir.plgx" "./bin/KeePassPasswordPractice-$version.plgx" || fail 1

echo
read -rsn 1 -p "Press any key to continue..."
