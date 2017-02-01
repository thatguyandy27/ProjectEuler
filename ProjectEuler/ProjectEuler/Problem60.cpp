//
//  Problem60.cpp
//  ProjectEuler
//
//  Created by Andy Meyers on 1/31/17.
//  Copyright © 2017 Andrew Meyers. All rights reserved.
//

#include "Problem60.h"
#include <vector>
#include <map>
#include <iostream>
#include <cmath>
#include <list>

using namespace std;

int combine(int a, int b) {
    int times = 1;
    while (times <= b)
        times *= 10;
    return a*times + b;
}



// it is a prime pair if they are both prime and they both concat into a prime
bool Problem60::is_prime_pair(int i1, int i2){
    if (prime_hash[i1] && prime_hash[i2]){
        return prime_hash[combine(i1, i2)] && prime_hash[combine(i2, i1)];
    }
    
    return false;
}



void Problem60::generate_answer(){
    int MAX_PRIMES = 100000000,
        MAX_TRIES = 30000;
    primes =  Prime::GeneratePrimes(MAX_PRIMES);
    prime_hash = Prime::GetSeive(MAX_PRIMES);
    map<int, list<int>> prime_pairs; // prime buddies
    

    for(long i = 0; i < primes.size(); i ++){
        
        int prime = primes[i],
            count = 0,
            leftNum = prime, rightNum = 0;
        
        
        while(leftNum >= 20){
            int leftDig = leftNum % 10;
            for (int j = 0; j < count; j++) {
                leftDig *= 10;
            }
            count++;
            rightNum += leftDig;
            leftNum /= 10;
            
            // OK have 2 new numbers
            
            if (is_prime_pair(leftNum, rightNum)){
                
                // do something with the prime pair
                prime_pairs[leftNum].push_back(rightNum);
                prime_pairs[rightNum].push_back(leftNum);
            }
        }
    }
    
    
    cout << "---------------checking for primes---------------" << endl;
    
    // loop through all primes
    for(int i = 0; i < primes.size(); i++){
        int prime = primes[i];
        
        if (prime > MAX_TRIES){
            break;
        }
        
        // see if it has pairs & at least 5
        if (prime_pairs.find(prime) != prime_pairs.end()){
            list<int> primes_to_test = prime_pairs[prime];
            primes_to_test.sort();
            primes_to_test.unique();
            
            if(primes_to_test.size() >= 4 || prime == 13 ||
               prime == 5197 || prime ==  5701 || prime ==  6733 || prime ==  8389){
                
                // make sure that they all have the same guys
                cout << "Prime: " << prime << ", matches -> ";

            
                auto it = primes_to_test.begin();
                while (it != primes_to_test.end()) {
                    cout << *it << ", ";
                    it++;
                }
            
                cout << endl;
            }
        }
        else if( prime == 13 || prime == 5197 || prime ==  5701 || prime ==  6733 || prime ==  8389) {
            cout << "WRITE IT OUT" << prime << endl;
        }
    }
    
    
}
