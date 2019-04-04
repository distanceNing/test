//
// Created by ninggyang(杨宁) on 2019-04-01.
//

#include <iostream>
#include <vector>
using namespace std;
class Solution {
public:
    int removeDuplicates(vector<int>& nums) {
        if(nums.empty())
            return  0;
        int len = 0;
        int count = 1;
        size_t size = nums.size();
        if(nums[size - 1] == 0)
            nums.push_back(1);
        else
            nums.push_back(0);

        for(auto i = 1; i < size + 1; ++i){
            if( nums[i] != nums[i-1]){
                nums[len++] = nums[i - 1];
                if(count >= 2){
                    nums[len++] = nums[i - 1];
                }
                count = 1;
            }else{
                count++;
            }
        }
        nums.pop_back();
        return len;
    }
};

typedef struct {
    int a;
    int b;
} st;

void test(){
    st a[10];

    st *p = a;

    new (p) st{1,2};


    std::cout<<p->a<<std::endl;
}