
def collapse_triangle(triangle)
  
  return nil if triangle.length == 0
  
  previous_row = Array.new(triangle[triangle.length-1].length, 0)
  
  triangle.reverse_each do |row|
    previous_row = collapse_row(row, previous_row)
  end
  
  return previous_row
end

def collapse_row(row, previous_row)

  return [row[0] + previous_row[0]] if row.length == 1
   
  newRow = []
  
  row.each_index do |n|

    break if n == row.length - 1
      
    if row[n] + previous_row[n] > row[n + 1]  + previous_row[n + 1]
      newRow << row[n] + previous_row[n]
    else
      newRow << row[n + 1] + previous_row[n + 1]
    end 
    
  end
  return newRow
end

def read_file(file_name)
  triangle =[]
  File.open(file_name, "r").each_line do |line|
    new_row = line.split(" ")
    new_row.map! do |x|
      x.to_i
    end
    triangle << new_row
  end
  
  return triangle
end

triangle = read_file("triangle_67.txt")
result = collapse_triangle(triangle)
puts result
