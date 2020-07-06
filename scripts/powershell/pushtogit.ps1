
function global:pushtogit{
    git add .
    git commit -m $args[0]
    git push
}

# sthd dhoty got "arguments" which are string passed in with command

pushtogit $args[0]