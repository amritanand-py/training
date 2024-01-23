rate=20
full=8
wage=0
part=4
echo "enter either part or full"
read role
if [ $role == "part" ]
then
	wage = $(( rate*part))
	echo $wage
else
	wage = $(( rate * full))
fi
