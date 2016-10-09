//
//  Problem99.cpp
//  ProjectEuler
//
//  Created by Andrew Meyers on 10/9/16.
//  Copyright © 2016 Andrew Meyers. All rights reserved.
//

#include "Problem99.h"
#include <math.h>
#include <iostream>
#include <string>
#include <fstream>
#include <sstream>
#include <algorithm>

using namespace std;

void Problem99::generate_answer(){
    load_data();
    double max_value = 0;
    int line_number = 1,
        max_line_number = 1;
    
    for(vector<vector<double>>::const_iterator it = values.begin(); it != values.end(); it++){
        double value,
            n1 = (*it)[0],
            n2 = (*it)[1];
        
        value = n2 * log(n1);
        
        if(max_value < value){
            max_line_number = line_number;
            max_value = value;
        }
        
        line_number++;
        
    }
    
    
    cout<< "Max line number: " << max_line_number <<  endl;
}

void Problem99::load_data(){
    static string FILE_NAME = "/Users/ameyers/github/ProjectEuler/ProjectEuler/ProjectEuler/p099_base_exp.txt";
    string line;
    ifstream myfile(FILE_NAME);
    while (getline( myfile, line )){
        vector<double> numbers;
        
        stringstream ss(line);
        
        double value;
        
        while (ss >> value)
        {
            numbers.push_back(value);
            
            if (ss.peek() == ',')
                ss.ignore();
        }
        
        values.push_back(numbers);
    }

}