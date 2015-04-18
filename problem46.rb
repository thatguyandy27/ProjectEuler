require 'Prime'

class Problem46

  def find_solution
    is_found = false
    solution = 1
    while !is_found
      solution += 2

      if !Prime.prime?(solution)

        is_found = check_number(solution)
        puts solution
      end
    end

    return solution

  end

  private 

    def check_number(num)
      Prime.each(num) do |prime|

        1.upto( num / 2) do |squ|

          return false if num == prime + 2 * (squ ** 2)
        end

      end

      return true
    end

end

problem46 = Problem46.new

puts problem46.find_solution