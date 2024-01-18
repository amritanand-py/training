num=$((RANDOM % 2))
if [ $num -eq 1 ]
then
	echo "present"
else
	echo "Absent"
fi
