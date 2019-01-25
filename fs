#!/bin/bash

# A small script to help find students in the course that you are grading. Use
# with caution. Cannot be run on the pi-clusters (no finger command)

echo -n "Please enter a course (like cs30x): "
read class

while [ 1 -eq 1 ]; do

  # Grab name to search for
  echo -n "Please enter a name or 'q' to quit: "
  read student

  if [ $student == "q" ]; then

    exit 0
  fi

  # Start the timer
  echo "Starting..."
  start=$(date +%s.%N)

  listclass $class | grep $student

  echo -n "Please enter a student to get more info from: "
  read stuname

  finger $stuname


  # Stop the timer
  end=$(date +%s.%N)

  # Calculate how long execution took
  elapsed=$(echo "$end - $start" | bc)

  # Report diagnostic output
  printf "Execution time: %.6f seconds\n" $elapsed
done
