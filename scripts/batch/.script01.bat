echo hello, this is an amazing file in Windows

md FolderA
cd FolderA
echo "Line01" > file01.txt
echo "Line02" >> file01.txt
echo "Line02\nline04" >> file01.txt
copy file01.txt file02.txt
type file01.txt