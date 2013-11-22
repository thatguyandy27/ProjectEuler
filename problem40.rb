
def compute_string(max_length)
  
  string = ''
  index = 1
  while string.length < max_length
    string += index.to_s
    index += 1
  end
  return string
end



string = compute_string(1000000)

result = string[0].to_i * string[9].to_i * string[99].to_i * string[999].to_i * string[9999].to_i* string[99999].to_i * string[999999].to_i

puts result

#210