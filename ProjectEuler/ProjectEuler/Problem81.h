//
//  Problem81.h
//  ProjectEuler
//
//  Created by Andrew Meyers on 10/7/16.
//  Copyright © 2016 Andrew Meyers. All rights reserved.
//

#ifndef Problem81_h
#define Problem81_h

#include <vector>

class Problem81{
public:
    void generate_answer();
    
private:
    std::vector<std::vector<int>> table;
    std::vector<std::vector<int>> table_cache;
    int get_total(std::vector<std::vector<int>>::size_type, std::vector<int>::size_type, int);
    int get_total();
    int min_value;
    void load_data();
};

#endif /* Problem81_hpp */
