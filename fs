#!/bin/bash

# A small script to help find students in the course that you are grading. Use
# with caution. Cannot be run on the pi-clusters (no finger command)

while [ 1 -eq 1 ]; do
  cd ~/..

  # Grab name to search for
  echo -n "Please enter a name or 'q' to quit: "
  read student

  if [ $student == "q" ]; then

    exit 0
  fi

  # Start the timer
  echo "Starting..."
  start=$(date +%s.%N)

  for name in *; do

    # Remove default non-student names
    if [[ $name != "hold" ]] && [[ $name != "public" ]] && [[ $name != "'" ]]; then

      # Look for the given name in accounts
      result=`finger $name | grep -c "$student"`

      # Print matches
      if [ $result -ne 0 ]; then
        finger $name
      fi
    fi
  done

  # Stop the timer
  end=$(date +%s.%N)

  # Calculate how long execution took
  elapsed=$(echo "$end - $start" | bc)

  # Report diagnostic output
  printf "Execution time: %.6f seconds\n" $elapsed
done
