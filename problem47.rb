require 'prime'  

class Problem47

  def solve_problem

    @primes = Prime.first(100)

    count = 0
    first_num = nil
    current_num = 2

    while count < 4

      factors = get_factors(current_num)

      if (factors.keys.length == 4)
        first_num = current_num if (first_num == nil)
        count +=1

      else
        first_num = nil
        count = 0

      end
      puts "#{current_num} + #{factors.keys.length}"

      current_num+=1

    end

    return count
  end

  private

    def get_factors(num)

      factors = Hash.new(0)
      primeIndex = 0

      while (!Prime.prime?(num))

        nextPrime = @primes[primeIndex]

        while (num % nextPrime == 0 && num != nextPrime)
          factors[nextPrime] += 1
          num = num / nextPrime
        end

        primeIndex += 1

      end

      factors[num] +=1

      return factors

    end


end


problem47 = Problem47.new

puts "#{problem47.solve_problem()}"