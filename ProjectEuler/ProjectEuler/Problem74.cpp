//
//  Problem74.cpp
//  ProjectEuler
//
//  Created by Andrew Meyers on 10/12/16.
//  Copyright © 2016 Andrew Meyers. All rights reserved.
//

#include "Problem74.h"
#include <iostream>
#include <set>

using namespace std;


static int MAX_NUM = 2177282;
static int MAX_CHECK = 1000000;
static int FACTORIALS[] = {
  1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880
};

void Problem74::generate_answer(){
    update_factorial_sums();
    
    set_chains_of_sixty();
}

void Problem74::update_factorial_sums(){
    for(int i = 0; i < MAX_NUM; i++){
        factorial_sums.push_back(get_sum_of_factorials(i));
    }
    
}

void Problem74::set_chains_of_sixty(){
    int count_of_sixties = 0;
//    for(int i = 0; i < MAX_CHECK; i++){
//        is_chain_of_sixty.push_back(0);
//    }
//    
    
    for(int i = 69; i < MAX_CHECK; i++){
        set<long> nums;
        // see if we already checked it
//        if(is_chain_of_sixty[i] == 0){

        // ok now we can loop till we find an end;
        long number = i;
        int count = 0;
        while(nums.find(number) == nums.end()){
            count++;
            nums.insert(number);
            number = get_sum_of_factorials(number);
        }
        
        if(count == 60){
            count_of_sixties++;
        }
//        }
        
    }
    
    cout<< "The number of sixties are " << count_of_sixties << endl;
    
}

long Problem74::get_sum_of_factorials(long num){
    long sum = 0;
    
    
    while(num > 0){
        sum += FACTORIALS[num % 10];
    
        num /= 10;

    }
    
    
    return sum;
}