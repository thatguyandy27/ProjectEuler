//
//  Prime.cpp
//  ProjectEuler
//
//  Created by Andy Meyers on 1/31/17.
//  Copyright © 2017 Andrew Meyers. All rights reserved.
//

#include "Prime.h"

using namespace std;

vector<int> Prime::GeneratePrimes(int max_num){
    
    vector<bool> seive = GetSeive(max_num);
    vector<int> primes;
    
    for (int i = 0; i < seive.size(); i++) {
        if (seive[i]){
            primes.push_back(i);
        }
    }
    
    return primes;
    
}

vector<bool> Prime::GetSeive(int num_max){
    // Make an array indicating whether numbers are prime.
    vector<bool> is_prime (num_max + 1, true);
    
    is_prime[0] = false;
    is_prime[1] = false;
    
    // Cross out multiples.
    for (int i = 2; i <= num_max; i++)
    {
        // See if i is prime.
        if (is_prime[i])
        {
            // Knock out multiples of i.
            for (int j = i * 2; j <= num_max; j += i)
                is_prime[j] = false;
        }
    }
    return is_prime;
}
