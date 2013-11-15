require 'Set'

def get_distinct_values(min, max)
  set = Set.new
  
  min.upto(max) do |a|
    min.upto(max) do |b|
      set.add(a**b)
    end
  end
  
  return set.count
end

min = 2 
max = 100
count = get_distinct_values(min, max)
puts "There are #{count} distinct values from #{min} to #{max}"

#the answer is 9183

